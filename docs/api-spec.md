# API Specification: Task Endpoints

## Base URL
`/api/task`

## Endpoints

### Get all tasks
- `GET /api/task`
- Response: 200 OK, array of TaskDto

### Get task by ID
- `GET /api/task/{id}`
- Response: 200 OK, TaskDto; 404 if not found

### Create task
- `POST /api/task`
- Body: TaskDto (no Id required)
- Response: 201 Created, TaskDto

### Update task
- `PUT /api/task/{id}`
- Body: TaskDto (Id must match URL)
- Response: 204 No Content; 400 if Id mismatch

### Delete task
- `DELETE /api/task/{id}`
- Response: 204 No Content 