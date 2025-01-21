import Alert from "./Components/Alert";
import Button from "./Components/Button";
//import ListGroup from "./Components/ListGroup";

function App()
{
  return (
    <div>
      <Alert> 
        Hello World
      </Alert>
      <Button onClick={() => console.log('clicked')}>
        My Button
      </Button>
    </div>
  )
}

export default App;
