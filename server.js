require("dotenv").config();
const express = require("express");
const cors = require("cors");
const Anthropic = require("@anthropic-ai/sdk");

const app = express();
const PORT = 5000;

app.use(cors({ origin: ["http://localhost:3000", "http://localhost:3001", "https://ai-chatbot-web.onrender.com", "http://ai-chatbot-web.onrender.com"] }));
app.use(express.json());

const Anthropic2 = Anthropic.default || Anthropic;
const client = new Anthropic2({ apiKey: process.env.ANTHROPIC_API_KEY });

app.post("/api/chat", async (req, res) => {
  const { messages } = req.body;

  if (!messages || !Array.isArray(messages)) {
    return res.status(400).json({ error: "messages array is required" });
  }

  try {
    const response = await client.messages.create({
      model: "claude-sonnet-4-6",
      max_tokens: 1024,
      system:
        "You are a helpful, friendly, and knowledgeable AI assistant. Provide clear, concise, and accurate responses.",
      messages: messages.map((m) => ({
        role: m.role,
        content: m.content,
      })),
    });

    res.json({ reply: response.content[0].text });
  } catch (err) {
    console.error("Anthropic API error:", err.message);
    res.status(500).json({ error: "Failed to get response from AI." });
  }
});

app.listen(PORT, () => {
  console.log(`Server running on http://localhost:${PORT}`);
});
