בס"ד
מכון כושר:
תיאור הפרויקט:
מערכת לניהול מכון כושר הכולל עדכון, הוספת, הצגת ומחיקת תלמידה, עדכון, הוספת, הצגת ומחיקת קורס, עדכון, הוספת, הצגת ומחיקת מורה, עדכון, הוספת, הצגת ומחיקת שיעור.
ישויות:
•	מתעמל
•	מורה
•	שיעור
•	קורס
מיפוי למתעמל:
עדכון מתעמל-
PUT(ID) https://Studio-Chen.co.il/gymnast/{id}
שליפת רשימת מתעמלים-
GET() https://Studio-Chen.co.il/gymnast
הוספת מתעמל-
POST(ID) https:// Studio-Chen.co.il/gymnast/{id}
מחיקת מתעמל-
DELETE(ID) https:// Studio-Chen.co.il/gymnast/{id}
עדכון קורס נוסף למתעמל רשום-
PUT(ID) https:// Studio-Chen.co.il/gymnast/{id}
שליפת מתעמל-
GET(ID) https:// Studio-Chen.co.il/gymnast/{id}
מיפוי למורה:
שליפת רשימת מורים/ות-
GET() https:// Studio-Chen.co.il/teacher
שליפת מורה-
GET(ID) https:// Studio-Chen.co.il/teacher/{id}
עדכון מורה-
PUT(ID) https:// Studio-Chen.co.il/teacher/{id}
עדכון קורס למורה-
PUT(ID) https:// Studio-Chen.co.il/teacher/{id}
הוספת מורה-
POST() https:// Studio-Chen.co.il/teacher
מחיקת מורה-
DELETE(ID) https:// Studio-Chen.co.il/teacher/{id}
מיפוי לקורס:
שליפת כל הקורסים-
GET() https:// Studio-Chen.co.il/course
 שליפת קורס-
GET(ID) https:// Studio-Chen.co.il/course/{id}
שליפת ציוד נדרש לקורס-
GET(ID) https:// Studio-Chen.co.il/course/{id}/ equipment
שליפת שיעורים בקורס-
GET(ID) https:// Studio-Chen.co.il/course/{id}/ lesson
עדכון קורס-
PUT(ID) https:// Studio-Chen.co.il/course/{id}
עדכון סטטוס קורס-
PUT()  https:// Studio-Chen.co.il/course/{id}/status
הוספת קורס-
POST() https:// Studio-Chen.co.il/course
מחיקת קורס-
DELETE(ID) https:// Studio-Chen.co.il/course/{id}
מיפוי לשיעור:
שליפת כל השיעורים-
GET()  https:// Studio-Chen.co.il/lesson
שליפת שיעור-
GET()  https:// Studio-Chen.co.il/ lesson /{id}
עדכון שיעור-
PUT()  https:// Studio-Chen.co.il/ lesson /{id}
הוספת שיעור-
POST()  https:// Studio-Chen.co.il/ lesson /{id}
מחיקת שיעור-
GET()  https:// Studio-Chen.co.il/ lesson /{id}
שדות נתונים:
מתעמל-
שם פרטי
שם משפחה
ת.ז
תאריך לידה
פלאפון
טלפון
אימייל
עיר
רחוב
מספר
מיקוד
קורס
מורה-
שם פרטי
שם משפחה
ת.ז
תאריך לידה
פלאפון
טלפון
אימייל
עיר
רחוב
מספר
מיקוד
רשימת קורסים שמלמדת
קורס-
מזהה קורס
סוג הקורס
מספר מפגשים
תאריך התחלה
תאריך סיום
מורה
רשימת ציוד נדרש
רשימת מתעמלים
שיעור-
מזהה שיעור
מזהה קורס
מספר מפגש
תאריך
שעת התחלה
שעת סיום
מורה
רשימת מתעמלים

