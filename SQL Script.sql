
CREATE TABLE Books (
ID INT PRIMARY KEY IDENTITY(1,1),
Publisher VARCHAR(150),
Title VARCHAR(100),
AuthorLastName VARCHAR(100),
AuthorFirstName VARCHAR(100),
TitleOfContainer VARCHAR(MAX),
Price DECIMAL(18,2),
PlaceOfPublication VARCHAR(255),
PublicationDate DATE, 
PageCount INT 
);

INSERT INTO Books (Publisher, Title, AuthorLastName, AuthorFirstName, TitleOfContainer, Price, PlaceOfPublication, PublicationDate, PageCount)
VALUES
('Penguin Random House', 'The Great Adventure', 'Smith', 'John', 'Adventure Tales', 19.99, 'New York', '2021-05-15', 350),
('HarperCollins', 'Mystery in the Shadows', 'Johnson', 'Emily', 'Shadows Series', 12.50, 'London', '2019-08-03', 270),
('Macmillan', 'Data Science 101', 'Brown', 'Michael', 'Tech Guides', 45.00, 'San Francisco', '2020-11-10', 400),
('Oxford Press', 'History of Ancient Civilizations', 'Williams', 'Sarah', 'World History Series', 30.75, 'Oxford', '2018-01-22', 600),
('Scholastic', 'The Magic of Nature', 'Davis', 'Rebecca', 'Nature Wonders', 16.99, 'Chicago', '2022-07-01', 320);


CREATE PROCEDURE FetechSortedBy_PublisherAuthorTitle
AS
BEGIN 

SELECT * FROM Books ORDER BY Publisher, AuthorLastName, AuthorFirstName, Title;

END;


CREATE PROCEDURE FetchSortedBy_AuthorTitle
AS
BEGIN
    SELECT * FROM Books ORDER BY AuthorLastName, AuthorFirstName, Title;
END;
