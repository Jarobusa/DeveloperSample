import React, { useState } from "react";
import './LoginForm.css';

const LoginForm = (props) => {
	const [currentUser, setCurrentUser] = useState('');
	const [users, setUsers] = useState([]);

	const handleSubmit = (event) =>{
		event.preventDefault();
		setUsers([...users, currentUser]);
		setCurrentUser('');

		props.onSubmit({
			login: undefined,
			password: undefined,
		});
	}

	return (
		<form className="form">
			<h1>Login</h1>
			<label htmlFor="name">Name</label>
			<input type="text"
				  value={currentUser}
				  onChange={(e) => setCurrentUser(e.target.value)}
				  id="name" />
			<label htmlFor="password">Password</label>
			<input type="password" id="password" />
			<button type="submit" onClick={handleSubmit}>Continue</button>
		</form>
	)
}

export default LoginForm;