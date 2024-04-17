import React from 'react'
import ReactDOM from 'react-dom/client'
import { Auth0Provider } from '@auth0/auth0-react'
import App from './App.tsx'
import './index.css'

ReactDOM.createRoot(document.getElementById('root')!).render(
  <Auth0Provider
  domain="dev-nankgjclquj5dcnq.us.auth0.com"
  clientId="g2g4M2Z0bCfp92yr6BriLAgoyObypPic"
  authorizationParams={{
    redirect_uri: window.location.origin
  }}
>
  <React.StrictMode>
    <App />
  </React.StrictMode>,
  </Auth0Provider>
)
