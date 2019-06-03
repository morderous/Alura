create database sql2;
use sql2;

SELECT 
    nome, email
FROM
    aluno
WHERE
    nome LIKE 'a%';

/* 1. Busque todos os alunos que não tenham nenhuma matrícula nos cursos. */
SELECT 
    aluno.nome
FROM
    aluno
WHERE
    NOT EXISTS( SELECT 
            matricula.id
        FROM
            matricula
        WHERE
            matricula.aluno_id = aluno.id);

/*EXEMPLO Poderíamos procurar por alunos que não tenham nenhuma matrícula nos últimos 6 meses */
SELECT 
    aluno.nome
FROM
    aluno
WHERE
    NOT EXISTS( SELECT 
            matricula.id
        FROM
            matricula
        WHERE
            matricula.aluno_id = aluno.id
                AND matricula.data > NOW() - INTERVAL 6 MONTH);
                
/*02 Busque todos os alunos que não tiveram nenhuma matrícula nos últimos 45 dias, usando a instrução EXISTS. */
SELECT 
    aluno.nome
FROM
    aluno
WHERE
    NOT EXISTS( SELECT 
            matricula.id
        FROM
            matricula
        WHERE
            matricula.aluno_id = aluno.id
                AND matricula.data > NOW() - INTERVAL 45 day);    
                

/* exercicios */

SELECT 
    *
FROM
    aluno
LIMIT 0 , 2;  

SELECT 
    *
FROM
    aluno
WHERE
    email LIKE '%.com'
LIMIT 0 , 2;    	

SELECT 
    *
FROM
    aluno
WHERE
    email LIKE '%.com'
ORDER BY
	nome
LIMIT 0 , 2; 

SELECT 
    *
FROM
    aluno
WHERE
    nome LIKE '%Silva%'
ORDER BY
	nome;  

/*Exiba a média das notas por curso.*/    
select c.nome, avg(n.nota)
from curso c
join matricula m on m.curso_id = c.id
join aluno a on m.aluno_id = a.id
join secao s on s.curso_id = m.curso_id
join exercicio e on s.id = e.secao_id
join resposta r on e.id = r.exercicio_id
join nota n on r.id = n.resposta_id
group by c.nome;


/*Exiba o nome do curso e a quantidade de matrículas, agrupadas por curso. Use a tabela matricula.*/
select c.nome, count(m.id) 
from matricula m 
join curso c on m.curso_id = c.id
group by c.nome;

/* Devolva o curso e as médias de notas, levando em conta somente alunos que tenham "Silva" ou "Santos" no sobrenome. */
select c.nome, avg(n.nota)
from curso c
join matricula m on m.curso_id = c.id
join aluno a on m.aluno_id = a.id
join secao s on s.curso_id = m.curso_id
join exercicio e on s.id = e.secao_id
join resposta r on e.id = r.exercicio_id
join nota n on r.id = n.resposta_id
where a.nome like '%silva%' or a.nome like'%Santos'
group by c.nome;

            