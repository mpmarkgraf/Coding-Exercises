import React from "react";
import "./LoginAttemptList.css";

const LoginAttempt = (props) => <li {...props}>{props.children}</li>;

const LoginAttemptList = (props) => {
	return(
		<div className="Attempt-List-Main">
			<p>Recent activity</p>
			<input type="input" placeholder="Filter..." />
			<ul className="Attempt-List">
				<LoginAttempt children={props.attempts}></LoginAttempt>
			</ul>
		</div>
	)
};

export default LoginAttemptList;