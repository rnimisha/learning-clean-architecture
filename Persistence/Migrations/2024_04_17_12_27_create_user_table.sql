CREATE TABLE users (
    id UUID PRIMARY KEY,
    email VARCHAR(50) NOT NULL,
    first_name VARCHAR(50) NOT NULL,
    last_name VARCHAR(50) NOT NULL,
    role VARCHAR(100) NOT NULL,
    refresh_token VARCHAR(200)
);

INSERT INTO users (id, email, first_name, last_name, role) VALUES ('0108734c-347a-46b9-ab00-8d97c085f241', 'test@gmail.com', 'test', 'thapa', 'admin');
