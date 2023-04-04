import React from "react";
import "./App.css";
import Header from "../Header";
import MovieList from "../movie/MovieList";

//We have added the Header (along with the slogan, which will be passed to the MovieList function using props)
//as well as calling the MovieList.
function App() {
  return (
    <div className="App">
      <Header slogan="Welcome to the greatest Movie Collection ever made." />
      <MovieList />
    </div>
  );
}

export default App;
