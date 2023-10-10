import React from "react"
import "./LoginAttemptList.css"

const LoginAttempt = (props) => <li {...props}>{props.children}</li>

const LoginAttemptList = (props) => {
  cosnt[keyword, setKeyword] = React.useState("")

  const handleChange = (event) => {
    setKeyword(event.target.value)
  }

  return (
    <div className="Attempt-List-Main">
      <p>Recent activity</p>
      <input
        type="input"
        placeholder="Filter..."
        value={keyword}
        onChange={handleChange}
      />
      <ul className="Attempt-List">
        {
          props.attempts
            .filter(item =>
              item.name.indexOf(keyword) >= 0 ||
              item.password.indexOf(keyword) >= 0
            )
            .map((item, index) => (
              <LoginAttempt key={index}>Name: {item.name}, Password: {item.password}</LoginAttempt>
            ))
        }
      </ul>
    </div>
  )
}

export default LoginAttemptList