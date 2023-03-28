# Travel API 

#### By E. Luckie ☀️

#### Build an API that allows users to `GET` and `POST` reviews about various travel destinations around the world.

* As a user, I want to GET and POST reviews about travel destinations.
* As a user, I want to GET reviews by country or city.
* As a user, I want to see the most popular travel destinations by number of reviews or by overall rating.
* As a user, I want to PUT and DELETE reviews, but only if I wrote them. (Start by requiring a user_name param to match the user_name of the author on the message. You can always try authentication later.)
* As a user, I want to look up random destinations just for fun.

## Technologies Used

* C#
* .NET 7.0
* API
* Postman
* Markdown
* Git

### Set Up and Run Project

1. Clone this repo.
2. Open the terminal and navigate to this project's production directory. called "TravelApi".
3. Within the production directory "TravelApi", create a new file called `appsettings.json`.
4. Within `appsettings.json`, put in the following code, replacing the `[YOUR-USERNAME-HERE]` and `[YOUR-PASSWORD-HERE]` with your own credentials for MySQL. 

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=travel_api;uid=[YOUR-USERNAME-HERE];pwd=[YOUR-PASSWORD-HERE];"
  }
}
```

5. Within the production directory "TravelApi", run `dotnet run` in the command line to start the project in development mode.

### Endpoints

GET http://localhost:5000/api/places/

GET http://localhost:5000/api/places/{id}

POST http://localhost:5000/api/places/

PUT http://localhost:5000/api/places/{id}

DELETE http://localhost:5000/api/places/{id}

### Optional Parameters


#### Example Queries
<!-- * The following query will return all places with a species value of "Dinosaur":
```GET http://localhost:5000/api/places?species=dinosaur```

* The following query will return all places with the name "Matilda":
```GET http://localhost:5000/api/places?name=matilda```

* The following query will return all places with an age of 10 or older:
```GET http://localhost:5000/api/places?minimumAge=10```

* It's possible to include multiple query strings by separating them with an `&`:
```GET http://localhost:5000/api/places?species=dinosaur&minimumAge=10``` -->


### Additional Requirements

<!-- #### for POST request -->

<!-- When making a POST request to `http://localhost:5000/api/places/`, you need to include a **body**. Here's an example body in JSON:

```json
{
  "species": "Tyrannosaurus Rex",
  "name": "Elizabeth",
  "age": 8
}
```

#### for PUT request
When making a PUT request to `http://localhost:5000/api/places/{id}`, you need to include a body that includes the animal's `animalId` property. Here's an example body in JSON:

```json
{
  "animalId": 1,
  "species": "Tyrannosaurus Rex",
  "name": "Lizzy",
  "age": 9
}
```

And here's the PUT request we would send the body to:

`http://localhost:5000/api/places/1` -->