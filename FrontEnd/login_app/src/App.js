import React, { useState } from "react";
import './App.css';
import LoginForm from './LoginForm';
import LoginAttemptList from './LoginAttemptList';

const App = () => {
  const [loginAttempts, setLoginAttempts] = useState([]);
  const [currentUser, setCurrentUser] = useState('');
  const [users, setUsers] = useState([]);

  const handleLogin = (event) => {
    event.preventDefault();
    setUsers([...users, currentUser]);
    setCurrentUser('');
  };


  return (
    <div className="App">
      <LoginForm onSubmit={({ login, password }) => console.log({ login, password })} />
      <LoginAttemptList attempts={loginAttempts} />
    </div>
  );
};

export default App;
