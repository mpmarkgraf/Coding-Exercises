import React, { useState } from "react";
import './App.css';
import LoginForm from './LoginForm';
import LoginAttemptList from './LoginAttemptList';

const App = () => {
  let [loginAttempts, setLoginAttempts] = useState([]);

  setLoginAttempts = (data) => {
    loginAttempts.push(data.login);
  }

  return (
    <div className="App">
      <LoginForm onSubmit={setLoginAttempts} />
      <LoginAttemptList attempts={loginAttempts} />
    </div>
  );
};

export default App;
