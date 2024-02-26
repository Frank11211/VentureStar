// Question 1
ALTER TABLE Subject MODIFY "Name" "nvarchar(150)";

// Question 2
SELECT * FROM student WHERE Name NOT IN ("Mike", "Michelle", "Milo")

SELECT * FROM subject WHERE Name IN ("English", "Mathematics", "Science", "Physic","Chemistry")

SELECT * FROM `exam` WHERE ExamDate = "2023-6-1"

SELECT * FROM `exam` ORDER BY Score ASC