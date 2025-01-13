import { Fragment } from "react/jsx-runtime";
import { MouseEvent } from "react";
function ListGroup()
{
    // fragment = <>
    const items = [
        'New York',
        'San Fran',
        'Tokyo',
        'London',
        'Paris'
    ];

    const handleCLick = (event: MouseEvent) => console.log(event);
    
    return (
        <> 
            <h1>List</h1>
            { items.length && <p>No items found</p> }
            <ul className="list-group">
                {items.map(item => 
                (<li 
                    className="list-group-item" 
                    key={item}
                    onClick={handleCLick}>
                        {item}
                    </li>
                ))}
            </ul>
        </>
    );
}

export default ListGroup;