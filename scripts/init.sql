CREATE DATABASE IF NOT EXISTS projectdb;
USE projectdb;

CREATE TABLE people (
    id INT AUTO_INCREMENT,
    name VARCHAR(255),
    lastName VARCHAR(255),
    role VARCHAR(255),
    PRIMARY KEY (id)
);

INSERT INTO people (name, lastName, role) VALUES ('Caleb', 'Espinoza', 'DevOps Engineer');
INSERT INTO people (name, lastName, role) VALUES ('Alberth', 'Condori', 'Software Engineer');
