import React, { useState } from "react";
import './App.css';
import LoginForm from './LoginForm';
import LoginAttemptList from './LoginAttemptList';

const App = () => {
  const [loginAttempts, setLoginAttempts] = useState([]);
  const [currentUser, setCurrentUser] = useState('');
  const [users, setUsers] = useState([]);

  const handleLoginAttempt = (event, loginAttempt) => {
    event.preventDefault();
    setUsers([...users, currentUser]);
    setLoginAttempts([...loginAttempts, loginAttempt]);
    setCurrentUser('');
  };  

  return (
    <div className="App">
      <LoginForm onSubmit={({ login, password }) => handleLoginAttempt(event, login)} />
      <LoginAttemptList attempts={loginAttempts} />
    </div>
  );
};

export default App;
