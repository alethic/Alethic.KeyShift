Launch two copies. Set the URL for each:

`Alethic.KeyShift.Console.exe --url=http://localhost:5000 Alethic.KeyShift:Uri=http://localhost:5000/host`

Change the port number for each copy.

GET and PUT values at `http://localhost:{port}/keys/{keyname}` to each service. They should see each other.