import React from "react";
import "./LoginAttemptList.css";

const LoginAttemptList = (props) => 
{
	return (
		<div className="Attempt-List-Main">
			<p>Recent activity</p>
			<input type="input" placeholder="Filter..." onChange={event => props.filter(event.target.value)} />
			<ul className="Attempt-List">
				{props.attempts.map(login =>
					<li>{login}</li>
				)}
			</ul>
		</div>
	);
}

export default LoginAttemptList;