CREATE TABLE IF NOT EXISTS rescates (
    Id SERIAL PRIMARY KEY,
    NumeroRescate VARCHAR(10),
    FechaRescate DATE,
    Superfamilia VARCHAR(70),
    GradoAfectacion INT,
    Localizacion VARCHAR(100),
    FOREIGN KEY (Superfamilia) REFERENCES animals(Superfamilia)
);