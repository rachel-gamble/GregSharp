CREATE TABLE
    IF NOT EXISTS accounts(
        id VARCHAR(255) NOT NULL primary key COMMENT 'primary key',
        createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
        updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update',
        name varchar(255) COMMENT 'User Name',
        email varchar(255) COMMENT 'User Email',
        picture varchar(255) COMMENT 'User Picture'
    ) default charset utf8 COMMENT '';

-- SECTION CARS

CREATE TABLE
    cars(
        id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
        make VARCHAR(255) NOT NULL,
        model VARCHAR(255) NOT NULL,
        year INT NOT NULL,
        price DOUBLE NOT NULL,
        description TEXT,
        color VARCHAR(10),
        imgUrl VARCHAR(255),
        createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
        updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update'
    ) default charset utf8mb4 COMMENT "for the emojis";

DROP TABLE cars;

INSERT INTO
    cars (
        make,
        model,
        year,
        price,
        color,
        `imgUrl`,
        description
    )
VALUES (
        'Toyota',
        'Bugati',
        2000,
        12.99,
        '#000000',
        'https://s1.cdn.autoevolution.com/images/news/bugatti-chiron-gets-toyota-camry-face-swap-design-still-works-139036_1.jpg',
        'A Sick black toyota bugati hotwheels'
    );

INSERT INTO
    cars (
        make,
        model,
        year,
        price,
        color,
        `imgUrl`,
        description
    )
VALUES (
        'Toyota',
        'Telsa',
        2000,
        1200.50,
        '#FFFFFF',
        'https://i.insider.com/617c5be123745d0018244b86?width=1136&format=jpeg',
        'A Sick competetor for the other one of a similar name, please do not sue us.'
    );

INSERT INTO
    cars (
        make,
        model,
        year,
        price,
        color,
        `imgUrl`,
        description
    )
VALUES (
        'Toyota',
        'Slingshot',
        2002,
        150.50,
        '#FFFFFF',
        'https://cdn1.polaris.com/globalassets/slingshot/2023/model/vehicle-cards/us/slingshot-slr-us-my23-a85a-red-shadow-m.png?v=ac0e4548&format=webp',
        'Everything rattles out of the box.'
    );

INSERT INTO
    cars (
        make,
        model,
        year,
        price,
        color,
        `imgUrl`,
        description
    )
VALUES (
        '🦧',
        'Oslo',
        2002,
        150.50,
        '#FFFFFF',
        'https://images.squarespace-cdn.com/content/v1/5a00ee59914e6b9803131e8f/f8c7ef16-ca18-4317-b30a-82a61e1bd8d9/Screen+Shot+2022-01-02+at+7.05.51+PM.png',
        'Everything rattles out of the box.'
    );

SELECT LAST_INSERT_ID();

-- PUT or update car

UPDATE cars
Set
    make = '🚤',
    model = 'speedboat',
    year = 2222,
    color = 'rock',
    description = "What i've been driving to school these days",
    imgUrl = "https://sportshub.cbsistatic.com/i/2021/03/17/9ec01251-4341-459a-9bc2-c222ea9f7418/spongebob-squarepants-boulder-1177707.jpg"
WHERE id = 7;

DELETE from cars WHERE id = 120;

-- SECTION HOUSES

CREATE TABLE
    houses(
        id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
        title VARCHAR(255),
        price DOUBLE NOT NULL,
        address VARCHAR(255),
        bedrooms INT NOT NULL,
        bathrooms DOUBLE NOT NULL,
        levels DOUBLE NOT NULL,
        year INT NOT NULL,
        imgUrl VARCHAR(255),
        description TEXT,
        createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
        updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update'
    ) default charset utf8mb4 COMMENT "for the emojis";

DROP TABLE houses;

INSERT INTO
    houses (
        title,
        price,
        address,
        bedrooms,
        bathrooms,
        levels,
        year,
        `imgUrl`,
        description
    )
VALUES (
        'Beachside Condo 3 Bed 2.5 Bath',
        '500000',
        '123 Black Beach Ln, Thailand',
        3,
        2.5,
        1,
        2010,
        'https://images.unsplash.com/photo-1526786220381-1d21eedf92bf?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1170&q=80',
        'Classic beach cottage vibe with modern ammenities. *ON SALE*'
    );

INSERT INTO
    houses (
        title,
        price,
        address,
        bedrooms,
        bathrooms,
        levels,
        year,
        `imgUrl`,
        description
    )
VALUES (
        'Classic Italian Coastal Condo, 1 Bed 1 Bath',
        '400000',
        '69 Cobble Way, Italy',
        1,
        1,
        1,
        1940,
        'https://cdn.meretdemeures.com/media/CACHE/images/uploads/502585bb-d3ce-42fa-ab57-01c01aff8218/1fa6e2f642fc2fbb36f38b0b018bf5b8.JPG',
        'Beautiful cobblestone. 80 year old vintage building, new kitchen. Perfect studio for a single, couple or small family. Grape and olive trees outside.'
    );

SELECT LAST_INSERT_ID();

UPDATE houses
SET
    title = '🛥️ House Boat',
    price = '120000',
    address = 'Currently in Sparkle Cove',
    bedrooms = 1,
    bathrooms = 1,
    levels = 2.5 year = 2011,
    imgUrl = 'https://images.unsplash.com/photo-1589139312487-1918d32befe4?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1170&q=80',
    description = "It's a house, on a boat."
WHERE id = 4;

DELETE from houses WHERE id = 120;

-- SECTION JOBS