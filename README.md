# AI Chatbot Project

A full-stack AI chatbot application using React frontend, Node.js backend (with Claude AI), and an optional C# .NET API.

## 🚀 Quick Start

### Prerequisites
- **Node.js** (v14+) - [Download here](https://nodejs.org/)
- **npm** (comes with Node.js)
- **ANTHROPIC_API_KEY** - Get one from [Anthropic Console](https://console.anthropic.com)

### Installation

1. **Clone the repository**
```bash
git clone https://github.com/JASWANTH-JAS-PNG/Ai-Chatbot.git
cd Ai-Chatbot
```

2. **Install root dependencies**
```bash
npm install
```

3. **Install frontend dependencies**
```bash
cd ai-app
npm install
cd ..
```

4. **Set up environment variables**

Create a `.env` file in the root directory:
```
ANTHROPIC_API_KEY=your_api_key_here
```

### Running the Project

#### Option 1: Run Both Frontend & Backend Together (Recommended)
```bash
npm run dev
```
This will start:
- 📱 **React Frontend**: http://localhost:3000
- 🔧 **Node.js API**: http://localhost:5000

#### Option 2: Run Separately
```bash
# Terminal 1 - Backend API
npm run server

# Terminal 2 - Frontend
npm run client
```

### Available Scripts

| Command | Purpose |
|---------|---------|
| `npm run dev` | Runs frontend and backend concurrently |
| `npm run server` | Runs Node.js server on port 5000 |
| `npm run client` | Runs React app on port 3000 |

## 📁 Project Structure

```
Ai-Chatbot/
├── server.js              # Express.js server (Claude API wrapper)
├── package.json           # Root dependencies
├── ai-app/                # React frontend
│   ├── src/              # React components
│   ├── public/           # Static files
│   ├── package.json      # Frontend dependencies
│   └── ...
├── backend/              # C# .NET API (optional)
│   ├── Controllers/      # API endpoints
│   ├── Models/          # Data models
│   ├── Services/        # Business logic
│   └── ...
└── .env                  # Environment variables
```

## 🔧 Technology Stack

- **Frontend**: React 19
- **Backend API**: Express.js (Node.js)
- **AI Model**: Claude (Anthropic)
- **Alternative Backend**: C# .NET with Entity Framework
- **Database**: SQL Server (for C# backend)

## 📝 How It Works

1. **User Interface** (React) runs on `localhost:3000`
2. User sends a message to the chatbot
3. Frontend sends request to **Node.js API** on `localhost:5000`
4. API calls **Claude AI** using Anthropic SDK
5. Response is sent back to the frontend and displayed

## 🌐 Deployment Options

### 1. Deploy to Render (Recommended - Free)
- Frontend: Render (Static Site)
- Backend: Render (Web Service)
- [Deployment Guide](https://render.com/docs)

### 2. Deploy to Vercel + Railway
- Frontend: Vercel
- Backend: Railway
- [Railway Guide](https://railway.app/docs)

### 3. Deploy to Heroku (Legacy but free tier ended)
- Use Render or Railway instead

### 4. Deploy to Azure
- [Azure App Service Guide](https://docs.microsoft.com/en-us/azure/app-service/)

## 🐛 Troubleshooting

### Port Already in Use
```bash
# Kill process on port 3000 (React)
lsof -ti:3000 | xargs kill -9

# Kill process on port 5000 (Server)
lsof -ti:5000 | xargs kill -9
```

### CORS Errors
Ensure `.env` file has `ANTHROPIC_API_KEY` set correctly.

### Dependencies Issues
```bash
rm -rf node_modules ai-app/node_modules
npm install
cd ai-app && npm install && cd ..
```

## 📚 API Endpoints

### Chat Endpoint
```
POST http://localhost:5000/api/chat
Content-Type: application/json

{
  "messages": [
    {
      "role": "user",
      "content": "Hello!"
    }
  ]
}
```

## 🔐 Security Notes

- Never commit `.env` file to Git
- Keep `ANTHROPIC_API_KEY` secret
- Use environment variables for sensitive data

## 📞 Support

For issues, check:
- [Anthropic Documentation](https://docs.anthropic.com)
- [React Documentation](https://react.dev)
- [Express Documentation](https://expressjs.com)

## 📄 License

Private Project

---

**Happy Coding! 🎉**
