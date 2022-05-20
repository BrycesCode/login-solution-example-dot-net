# Login Example Using .NET
### Summary
This API allows new users to has there password using argon2. When loggin in argon2 will also verify if the password is correct or not. 

### roadmap
- Store hashed credentials in database
- Setup argon2 verification method
- Reset password endpoint
# Endpoints
## /GetUser
This endpoint will return a users information based on there email
## /InsertUser (Post)
This endpoint will allow users to store there credentials in a database with there password behind hashed in argon2
