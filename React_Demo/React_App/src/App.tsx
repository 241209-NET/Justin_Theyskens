import ListGroup from "./Components/ListGroup";
function App()
{
      const items = [
          'New York',
          'San Fran',
          'Tokyo',
          'London',
          'Paris'
      ];

      const handleSelectedItem = (item: string) => 
        {
          console.log(item);
        }

  // Always close react components
  return <div><ListGroup items={items} heading="Cities" onSelectItem={handleSelectedItem}/></div>
}

export default App;
