# Demo 2 - The WordCounter App

We'll run the demo app for the course, looking at how the managed code might use unmanaged resources.

## Pre-reqs

The demo uses a SQL Server database. The easiest way to run it is using [Docker Desktop]().

## Setup 

Start the database:

```
docker run -d -p 1433:1433 psdispose/word-count-db
```

## Run the app

> Open the WordCounter solution in Visual Studio and run the app

## Start the processing

Check book files:

```
ls 'A Tale of Two Cities'
```

Small file:

```
cp './A Tale of Two Cities/contents.txt' /books/ 
```

Larger file:

```
cp './A Tale of Two Cities/excerpt.txt' /books/ 
```

Full text:

```
cp './A Tale of Two Cities/pg98.txt' /books/ 
```