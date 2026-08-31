-- Table: public.aperson

-- DROP TABLE IF EXISTS public.aperson;

CREATE TABLE IF NOT EXISTS public.aperson
(
 	papscodeper character varying(25) COLLATE pg_catalog."default" NOT NULL,
    capsestper boolean,
    capsnumcid character varying(20) COLLATE pg_catalog."default",
    capsfec date,
    capssexper boolean,
    capsapemat character varying(50) COLLATE pg_catalog."default",
    capsapepat character varying(50) COLLATE pg_catalog."default",
    capsnomper character varying(100) COLLATE pg_catalog."default",
    capsnumcel character varying(25) COLLATE pg_catalog."default",
    capscorele character varying(100) COLLATE pg_catalog."default",
    capsdirper character varying(250) COLLATE pg_catalog."default",
    capsfotper character varying COLLATE pg_catalog."default",
    CONSTRAINT aperson_pkey PRIMARY KEY (papscodeper)
)

TABLESPACE pg_default;

ALTER TABLE IF EXISTS public.aperson
    OWNER to postgres;