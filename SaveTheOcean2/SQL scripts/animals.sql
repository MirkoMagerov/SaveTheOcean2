CREATE TABLE IF NOT EXISTS animals (
	Id SERIAL PRIMARY KEY,
	Nombre VARCHAR(50),
	Superfamilia VARCHAR(70),
	Especie VARCHAR (50),
	PesoAproximado DECIMAL
);