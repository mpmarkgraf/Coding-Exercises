import React, { useState } from "react";
import './LoginForm.css';

const LoginForm = (props) => {
	const [login, setLogin] = useState('');
	const [password, setPassword] = useState('');

	const handleSubmit = (event) => {
		event.preventDefault();

		props.onSubmit({
			login: login,
			password: password,
		});
		
		setLogin('');
		setPassword('');
	}

	return (
		<form className="form">
			<h1>Login</h1>
			<label htmlFor="name">Name</label>
			<input type="text" id="name" onChange={event => setLogin(event.target.value)} value={login} />
			<label htmlFor="password">Password</label>
			<input type="password" id="password" />
			<button type="submit" onClick={handleSubmit}>Continue</button>
		</form>
	)
}

export default LoginForm;