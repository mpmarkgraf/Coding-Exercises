import React, { useState } from "react";
import './App.css';
import LoginForm from './LoginForm';
import LoginAttemptList from './LoginAttemptList';

const App = () => {
  const [loginAttempts, setLoginAttempts] = useState([]);
  const [loginAttemptsMaster, setLoginAttemptsMaster] = useState([]);

  const pushLoginAttempt = (data) => {
    setLoginAttemptsMaster(loginArray => [...loginArray, data.login]);
    setLoginAttempts(loginArray => [...loginArray, data.login]);
  }

  const filterList = (filterTerm) => {
    if (filterTerm.trim().length > 0) {
      setLoginAttempts(loginAttempts.filter(x => x.includes(filterTerm)));
    } else {
      setLoginAttempts(loginAttemptsMaster);
    }
  }

  const clearList = () => {
    setLoginAttemptsMaster([]);
    setLoginAttempts([]);
  }

  return (
    <div className="App">
      <LoginForm onSubmit={({login, password}) => pushLoginAttempt({login, password})} />
      <button onClick={clearList}>Clear</button>
      <LoginAttemptList attempts={loginAttempts} filter={filterTerm => filterList(filterTerm)} />
    </div>
  );
};

export default App;
