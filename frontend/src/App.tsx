import './App.css';
import BowlerList from './BowlerList';
import bowling from './assets/bowling.jpg';

function HeaderComponent() {
  return (
    <>
      <h1>Bowling League</h1>
      <img src={bowling}></img>
      <p>
        This is a page that shows all of the bowlers in the league. However in
        this case we are just showing the Marlins and Sharks teams due to
        privacy reasons
      </p>
    </>
  );
}
function App() {
  return (
    <>
      <HeaderComponent />
      <BowlerList />
    </>
  );
}

export default App;
