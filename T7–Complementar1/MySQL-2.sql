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
                AND matricula.data > NOW() - INTERVAL 45 DAY);
                

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
ORDER BY nome
LIMIT 0 , 2;

SELECT 
    *
FROM
    aluno
WHERE
    nome LIKE '%Silva%'
ORDER BY nome;

/*Exiba a média das notas por curso.*/    
SELECT 
    c.nome, AVG(n.nota)
FROM
    curso c
        JOIN
    matricula m ON m.curso_id = c.id
        JOIN
    aluno a ON m.aluno_id = a.id
        JOIN
    secao s ON s.curso_id = m.curso_id
        JOIN
    exercicio e ON s.id = e.secao_id
        JOIN
    resposta r ON e.id = r.exercicio_id
        JOIN
    nota n ON r.id = n.resposta_id
GROUP BY c.nome;


/*Exiba o nome do curso e a quantidade de matrículas, agrupadas por curso. Use a tabela matricula.*/
SELECT 
    c.nome, COUNT(m.id)
FROM
    matricula m
        JOIN
    curso c ON m.curso_id = c.id
GROUP BY c.nome;

/* Devolva o curso e as médias de notas, levando em conta somente alunos que tenham "Silva" ou "Santos" no sobrenome. */
SELECT 
    c.nome, AVG(n.nota)
FROM
    curso c
        JOIN
    matricula m ON m.curso_id = c.id
        JOIN
    aluno a ON m.aluno_id = a.id
        JOIN
    secao s ON s.curso_id = m.curso_id
        JOIN
    exercicio e ON s.id = e.secao_id
        JOIN
    resposta r ON e.id = r.exercicio_id
        JOIN
    nota n ON r.id = n.resposta_id
WHERE
    a.nome LIKE '%silva%'
        OR a.nome LIKE '%Santos'
GROUP BY c.nome;

/*Conte a quantidade de respostas por exercício. Exiba a pergunta e o número de respostas.*/

SELECT 
    e.pergunta, COUNT(r.id)
FROM
    resposta r
        JOIN
    exercicio e ON r.exercicio_id = e.id
GROUP BY e.id
ORDER BY COUNT(r.id) DESC;

/* Podemos agrupar por mais de um campo de uma só vez. Por exemplo, se quisermos a média de notas por aluno por curso, podemos fazer GROUP BY aluno.id, curso.id.*/

SELECT 
    a.nome, c.nome, AVG(n.nota)
FROM
    curso c
        JOIN
    matricula m ON m.curso_id = c.id
        JOIN
    aluno a ON m.aluno_id = a.id
        JOIN
    secao s ON s.curso_id = m.curso_id
        JOIN
    exercicio e ON s.id = e.secao_id
        JOIN
    resposta r ON e.id = r.exercicio_id
        JOIN
    nota n ON r.id = n.resposta_id
GROUP BY a.id, c.id;

/* Devolva todos os alunos, cursos e a média de suas notas. Lembre-se de agrupar por aluno e por curso. Filtre também pela nota: só mostre alunos com nota média menor do que 5.*/
SELECT 
    a.nome, c.nome, AVG(n.nota)
FROM
    nota n
        JOIN
    resposta r ON r.id = n.resposta_id
        JOIN
    exercicio e ON e.id = r.exercicio_id
        JOIN
    secao s ON s.id = e.secao_id
        JOIN
    curso c ON c.id = s.curso_id
        JOIN
    aluno a ON a.id = r.aluno_id
GROUP BY c.nome , a.nome
HAVING AVG(n.nota) < 5;

/*Exiba todos os cursos e a sua quantidade de matrículas. Contudo, exiba somente cursos que tenham mais de uma matrícula.*/
SELECT 
    c.nome, COUNT(m.id)
FROM
    matricula m
        JOIN
    curso c ON m.curso_id = c.id
GROUP BY c.nome
having
count(m.id) >=1;

/*Exiba o nome do curso e a quantidade de seções que existe nele. Mostre só cursos com mais de 3 seções.*/
select c.nome, count(s.id)
from curso c 
join secao s on s.curso_id = c.id
group by c.nome
having count(s.id) > 3;

desc matricula;

select distinct tipo from matricula;

select c.nome, count(m.id) from 
curso c join matricula m on c.id = m.curso_id
where m.tipo IN ('PAGA_PF', 'PAGA_PJ')
group by c.nome;

/*Traga todas as perguntas e a quantidade de respostas de cada uma. Mas dessa vez, somente dos cursos com ID 1 e 3.*/
select e.pergunta, r.resposta_dada  
from secao s 
join exercicio e on s.id = e.secao_id
join resposta r on e.id = r.exercicio_id
join curso c on s.curso_id = c.id
where c.id in (1, 3)
group by e.pergunta;

/* Exiba a média das notas por aluno, além de uma coluna com a diferença entre a média do aluno e a média geral. Use sub-queries para isso. */
SELECT 
    a.nome,
    AVG(n1.nota) AS media,
    AVG(n1.nota) - (SELECT 
            AVG(n2.nota)
        FROM
            nota n2
                JOIN
            resposta r2 ON n2.resposta_id = r2.id
        WHERE
            r2.aluno_id <> a.id) 
            AS diferenca
FROM
    nota n1
        JOIN
    resposta r ON r.id = n1.resposta_id
        JOIN
    exercicio e ON e.id = r.exercicio_id
        JOIN
    secao s ON s.id = e.secao_id
        JOIN
    aluno a ON a.id = r.aluno_id
    where
a.id in (select aluno_id from matricula where data < now() - interval 3 month)
group by  a.nome;

/* */
            
select c.nome, count(m.id) 'Matriculas',(select count(m.id) from matricula m join curso c on m.curso_id = c.id)-count(m.id) 'diferença' 
    from matricula m
	join curso c on m.curso_id = c.id
	group by c.nome;
    
    /* */
    select c.nome, count(m.id), 
count(m.id)/(select count(id) from matricula m)
from curso c join matricula m on m.curso_id = c.id
group by c.nome;

select a.nome, r.resposta_dada from 
aluno a left join resposta r on a.id = r.aluno_id;

select a.nome, r.resposta_dada from 
aluno a left join resposta r on a.id = r.aluno_id
and r.exercicio_id = 1