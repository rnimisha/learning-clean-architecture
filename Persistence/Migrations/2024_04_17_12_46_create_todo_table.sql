CREATE TABLE todos (
    id UUID PRIMARY KEY,
    title VARCHAR(50) NOT NULL,
    is_completed BOOLEAN NOT NULL DEFAULT FALSE,
    user_id UUID NOT NULL REFERENCES users(id)
);

