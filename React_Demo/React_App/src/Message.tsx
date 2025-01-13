function Message()
{
    //JSX : javascript xml
    const name = "Justin";
    if (name)
        return <h1>Hello {name}</h1>;
    else
        return <h1>Hello World</h1>;
}

export default Message;