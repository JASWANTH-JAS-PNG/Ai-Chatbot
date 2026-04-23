# 🚀 Deploy Your AI Chatbot Live

Get your app online in 5 minutes with **FREE** hosting!

## Option 1: Deploy to Render (RECOMMENDED)

### Step 1: Create Render Account
1. Go to https://render.com
2. Sign up with GitHub (use your account)

### Step 2: Deploy Backend (Node.js API)
1. Click **"New +"** → **"Web Service"**
2. Select **"Connect a repository"** → Choose your **Ai-Chatbot** repo
3. Fill in details:
   - **Name**: `ai-chatbot-api`
   - **Environment**: `Node`
   - **Build Command**: `npm install`
   - **Start Command**: `node server.js`
   - **Runtime**: `Node`
4. Click **"Advanced"** → Add environment variable:
   - **Key**: `ANTHROPIC_API_KEY`
   - **Value**: Your Anthropic API Key
5. Click **"Create Web Service"**
6. Wait 3-5 minutes → Copy the URL (e.g., `https://ai-chatbot-api.onrender.com`)

### Step 3: Deploy Frontend (React)
1. Update `ai-app/src` to point to deployed backend

Edit `ai-app/src/App.js` or wherever you make API calls:
```javascript
// Change from:
const API_URL = "http://localhost:5000";

// To:
const API_URL = "https://ai-chatbot-api.onrender.com";
```

2. Go back to Render → Click **"New +"** → **"Static Site"**
3. Connect your **Ai-Chatbot** repo again
4. Fill in:
   - **Name**: `ai-chatbot-web`
   - **Build Command**: `cd ai-app && npm install && npm run build`
   - **Publish Directory**: `ai-app/build`
5. Click **"Create Static Site"**
6. Wait 2-3 minutes → Get your live URL! 🎉

### Your Live URLs:
- 🎨 **Frontend**: `https://ai-chatbot-web.onrender.com`
- 🔧 **API**: `https://ai-chatbot-api.onrender.com`

---

## Option 2: Deploy to Vercel + Railway

### Frontend (Vercel - Free)
1. Go to https://vercel.com
2. Sign up with GitHub
3. Click **"Import Project"** → Select your repo
4. Set root directory to `ai-app`
5. Deploy! → Get URL

### Backend (Railway - Free)
1. Go to https://railway.app
2. Sign up with GitHub
3. Click **"New Project"** → **"Deploy from GitHub repo"**
4. Select your repo
5. Add environment variables:
   - `ANTHROPIC_API_KEY`
6. Railway auto-detects Node.js → Deploys automatically
7. Get your API URL from Railway dashboard

---

## Option 3: Local Testing with Ngrok (For Testing Only)

Get a temporary public URL:
```bash
npm install -g ngrok
ngrok http 5000
```

This gives you a URL like `https://xxx-xxx-xxx.ngrok.io` that points to your localhost!

---

## Testing Your Live App

1. Visit your frontend URL
2. Type a message
3. See AI response! ✨

---

## Common Issues

**API Not Responding?**
- Check ANTHROPIC_API_KEY is set in backend environment variables
- Frontend URL should point to deployed API URL

**Build Fails?**
- Ensure `ai-app/package.json` exists
- Check Node.js version (14+)

**CORS Errors?**
Update `server.js`:
```javascript
app.use(cors({ origin: "*" })); // Allow all origins
```

---

**🎉 Your app is now live! Share the link!**
