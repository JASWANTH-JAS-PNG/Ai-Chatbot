# 🚀 Deploy Your AI Chatbot in 5 Minutes

## Step 1: Deploy Backend API to Render

1. Go to https://render.com
2. Click **"New +"** → **"Web Service"**
3. Click **"Connect a repository"** 
4. Search & select: **`Ai-Chatbot`**
5. Fill in the form:
   - **Name:** `ai-chatbot-api`
   - **Environment:** Node
   - **Build Command:** `npm install`
   - **Start Command:** `node server.js`
6. Scroll to **"Environment"** → Add:
   - **Key:** `ANTHROPIC_API_KEY`
   - **Value:** Your Anthropic API key (from https://console.anthropic.com)
7. Click **"Create Web Service"**
8. ⏳ Wait 3-5 minutes for deployment
9. **Copy your API URL** (looks like: `https://ai-chatbot-api.onrender.com`)

✅ **Your API is now live!**

---

## Step 2: Deploy Frontend to Render

1. Go back to Render dashboard
2. Click **"New +"** → **"Static Site"**
3. Click **"Connect a repository"**
4. Select **`Ai-Chatbot`** again
5. Fill in:
   - **Name:** `ai-chatbot-web`
   - **Build Command:** `cd ai-app && npm install && npm run build`
   - **Publish directory:** `ai-app/build`
6. Click **"Create Static Site"**
7. ⏳ Wait 2-3 minutes
8. **Get your web URL** (looks like: `https://ai-chatbot-web.onrender.com`)

✅ **Your App is now LIVE!**

---

## Step 3: Update Your Repo README

Share these links:

```markdown
## 🎨 Live Demo
🌐 **[Visit the AI Chatbot](https://ai-chatbot-web.onrender.com)**

## 📦 GitHub
📍 **[Source Code](https://github.com/JASWANTH-JAS-PNG/Ai-Chatbot)**
```

---

## ✅ Your Live Links:
- 🎨 **Frontend:** https://ai-chatbot-web.onrender.com
- 🔧 **API:** https://ai-chatbot-api.onrender.com
- 📦 **Repo:** https://github.com/JASWANTH-JAS-PNG/Ai-Chatbot

**Share these with anyone! They can click and see your working AI chatbot!** 🎉

---

## 🆘 Troubleshooting

### API Not Working?
- Check your `ANTHROPIC_API_KEY` is correct
- Restart the service from Render dashboard

### Frontend Shows Blank?
- Make sure `ai-app/src` files exist
- Check build logs in Render dashboard

### CORS Errors?
The server.js already has CORS configured for Render domains. Should work!

---

**Questions?** Check Render docs: https://render.com/docs
