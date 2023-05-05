CREATE SEQUENCE public.aluno_seq START WITH 1 INCREMENT BY 1 NO MINVALUE NO MAXVALUE NO CYCLE;


CREATE SEQUENCE public.alunocurso_seq START WITH 1 INCREMENT BY 1 NO MINVALUE NO MAXVALUE NO CYCLE;


CREATE SEQUENCE public.curso_seq START WITH 1 INCREMENT BY 1 NO MINVALUE NO MAXVALUE NO CYCLE;


CREATE TABLE public.aluno (
    id int8 NOT NULL DEFAULT (nextval('public.aluno_seq')),
    cpf varchar(14) NULL,
    nome varchar(80) NULL,
    email varchar(200) NULL,
    datanascimento timestamp NULL,
    CONSTRAINT aluno_pkey PRIMARY KEY (id)
);


CREATE TABLE public.curso (
    id int8 NOT NULL DEFAULT (nextval('public.curso_seq')),
    nome varchar(50) NULL,
    descricao text NULL,
    nivel int4 NOT NULL,
    CONSTRAINT curso_pkey PRIMARY KEY (id),
    CONSTRAINT course_level_check CHECK (nivel IN (0,1,2))
);


CREATE TABLE public.alunocurso (
    id int8 NOT NULL DEFAULT (nextval('public.alunocurso_seq')),
    alunoid int8 NOT NULL,
    cursoid int8 NOT NULL,
    CONSTRAINT alunocurso_pkey PRIMARY KEY (id),
    CONSTRAINT fk_alunocurso_aluno_student_id FOREIGN KEY (alunoid) REFERENCES public.aluno (id),
    CONSTRAINT fk_alunocurso_curso_course_id FOREIGN KEY (cursoid) REFERENCES public.curso (id)
);


CREATE INDEX ix_alunocurso_course_id ON public.alunocurso (cursoid);


CREATE INDEX ix_alunocurso_student_id ON public.alunocurso (alunoid);


