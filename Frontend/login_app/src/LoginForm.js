import React from "react"
import './LoginForm.css'

const LoginForm = (props) => {
  const [credential, setCredential] = React.useState({
    name: "",
    password: "",
  })

  const handleChange = (event) => {
    setCredential({
      ...credential,
      [event.target.name]: event.target.value,
    })
  }

  const handleSubmit = (event) => {
    event.preventDefault();

    if (credential.name.length && credential.password.length) {
      props.onSubmit(credential)

      setCredential({
        name: "",
        password: "",
      })
    } else {
      console.error("Please provide name and password.")
    }
  }

  return (
    <form className="form">
      <h1>Login</h1>
      <label htmlFor="name">Name</label>
      <input
        type="text"
        name="name"
        onChange={handleChange}
        value={credential.name}
      />
      <label htmlFor="password">Password</label>
      <input
        type="password"
        name="password"
        onChange={handleChange}
        value={credential.password}
      />
      <button type="submit" onClick={handleSubmit}>Continue</button>
    </form>
  )
}

export default LoginForm