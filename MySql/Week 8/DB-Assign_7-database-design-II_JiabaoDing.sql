--YOUR NAME HERE	ASSIGNMENT 7 GROUPING RESULTS
--Put your answers on the lines after each letter. E.g. your query for question 1A should go on line 5; your query for question 1B should go on line 7...
-- 1 
--A
CREATE TABLE authors (
    AuthorID INT AUTO_INCREMENT PRIMARY KEY,
    Username VARCHAR(255),
    FullName VARCHAR(255),
    Email VARCHAR(255),
    Bio TEXT
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

CREATE TABLE posts (
    PostID INT AUTO_INCREMENT PRIMARY KEY,
    AuthorID INT,
    Title VARCHAR(255),
    Content TEXT,
    PublicationDate DATETIME,
    FOREIGN KEY (AuthorID) REFERENCES authors(AuthorID)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
--B
INSERT INTO authors (Username, FullName, Email, Bio) VALUES
    ('johndoe', 'John Doe', 'johndoe@example.com', 'John Doe is an experienced author.'),
    ('janesmith', 'Jane Smith', 'janesmith@example.com', 'Jane Smith enjoys writing and sharing her knowledge.'),
    ('alicejohnson', 'Alice Johnson', 'alicejohnson@example.com', 'Alice Johnson is passionate about literature and writing.');

INSERT INTO posts (AuthorID, Title, Content, PublicationDate) VALUES
    (1, 'My First Blog Post', 'This is the content of my first blog post.', '2023-01-15'),
    (2, 'Exploring SQL Statements', 'In this post, we will explore SQL statements and their usage.', '2023-02-20'),
    (3, 'The Art of Writing', 'Writing is an art that can be mastered with practice and dedication.', '2023-03-10');

-- 2
--A
CREATE TABLE Comments (
    CommentID INT AUTO_INCREMENT PRIMARY KEY,
    PostID INT,
    CommentText TEXT,
    FOREIGN KEY (PostID) REFERENCES posts(PostID)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--B
INSERT INTO Comments (PostID, CommentText) VALUES
    (1, 'This is an insightful comment on post 1.'),
    (2, 'I enjoyed reading this post. Great job!'),
    (3, 'Looking forward to more posts from this author.');

-- 3
--A
-- Add a new column "comment_date" to the Comments table
ALTER TABLE Comments
ADD comment_date DATE;

-- Update the "Comments" table to fill in the "comment_date" column
UPDATE Comments
SET comment_date = '2023-04-05'
WHERE CommentID = 1;

UPDATE Comments
SET comment_date = '2023-04-10'
WHERE CommentID = 2;

UPDATE Comments
SET comment_date = '2023-04-15'
WHERE CommentID = 3;

--B
DELETE a, p
FROM Authors AS a
JOIN Posts AS p ON a.author_id = p.author_id
ORDER BY a.author_id
LIMIT 2;

