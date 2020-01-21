USE master;

CREATE DATABASE SpotifyAppBD;
GO

USE SpotifyAppBD;


CREATE TABLE SpotifyPlayList
    (
      idList INT PRIMARY KEY
                 IDENTITY ,
      Titulo VARCHAR(150) NOT NULL ,
      Album VARCHAR(80) NOT NULL ,
      Artista VARCHAR(100) NOT NULL ,
      Duracion TIME NOT NULL
    );
GO

INSERT  INTO dbo.SpotifyPlayList
        ( Titulo ,
          Album ,
          Artista ,
          Duracion
        )
VALUES  ( 'I Follow Rivers' , -- Titulo - varchar(150)
          'Wounded Rhymes' , -- Album - varchar(80)
          'Lykke Li' , -- Artista - varchar(100)
          '4:42'  -- Duracion - time
        );

INSERT  INTO dbo.SpotifyPlayList
        ( Titulo ,
          Album ,
          Artista ,
          Duracion
        )
VALUES  ( 'Rosa e Laranja' , -- Titulo - varchar(150)
          'Simples' , -- Album - varchar(80)
          'Mariana Froes' , -- Artista - varchar(100)
          '5:48'  -- Duracion - time
        );

INSERT  INTO dbo.SpotifyPlayList
        ( Titulo ,
          Album ,
          Artista ,
          Duracion
        )
VALUES  ( 'Girassóis de Van Gogh' , -- Titulo - varchar(150)
          'Simples' , -- Album - varchar(80)
          'Mariana Froes' , -- Artista - varchar(100)
          '2:35'  -- Duracion - time
        );

INSERT  INTO dbo.SpotifyPlayList
        ( Titulo ,
          Album ,
          Artista ,
          Duracion
        )
VALUES  ( 'Lost On You' , -- Titulo - varchar(150)
          'Death Valley and Lost on You' , -- Album - varchar(80)
          'LP' , -- Artista - varchar(100)
          '5:08'  -- Duracion - time
        );

	