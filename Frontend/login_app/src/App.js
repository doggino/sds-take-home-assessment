import React, { useState } from "react"
import './App.css'
import LoginForm from './LoginForm'
import LoginAttemptList from './LoginAttemptList'

const App = () => {
  const [loginAttempts, setLoginAttempts] = useState([])

  const handleLoginSubmit = (credential) => {
    setLoginAttempts([...loginAttempts, credential])
  }

  return (
    <div className="App">
      <LoginForm onSubmit={handleLoginSubmit} />
      <LoginAttemptList attempts={loginAttempts} />
    </div>
  );
};

export default App
