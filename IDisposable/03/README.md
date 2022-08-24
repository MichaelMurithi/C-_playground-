# Demos

## Pre-reqs

The demos use a SQL Server database. The easiest way to run it is using [Docker Desktop]().

## Setup 

Start the database:

```
docker run -d -p 1433:1433 psdispose/sql-server:2019
```

Check it's running:

```
docker ps
```

## Run the app

> Open the SqlConsumer solution in Visual Studio and walk through the app with profiling on.


