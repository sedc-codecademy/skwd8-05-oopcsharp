# `Who Wants to Be a Millionaire?`

* Квизот може да го игра само еден играч
    - Играчот треба да одговори точно на 15 прашања за да стане милионер
    - Ако одговори погрешно на едно прашање играта завршува
    - Секое прашање има 4 понудени одговори
**Само еден одговор е точен**


* Играчот може да користи 3 шанси за помош
    - 50:50
    - Повикај пријател
    - Прашај ја публиката

---

#### Шаблон за работа:

### *`Quiz`*
- string Name
- List<Question>
- virtual void Start()

### *`QuizMillionaire`*
- Random rnd
- Question[] questions15
- Dictionary<string,int> answerChoices
- HelpAudience hAA
- HelpFriend hCF
- HelpFiftyFifty hFF
- void ShufflePossibleQuestions()
- void GenerateQuestion15()
- void PrintQuestion(int questionNumber, Question q)
- void PrintHelOptions()
- override void Start()

### *`Question`*
- string Text
- string[] PossibleAnswers
- int CorrectAnswer
- int SelectedAnswer

### *`HelpOption`*
- string Name
- bool IsUsed
- Random rnd
- virtual void UseHelpOption(Question q, Dictionary<string, int> answerChoices)

### *`HelpFriend`*
- override void UseHelpOption(Question q, Dictionary<string, int> answerChoices)

### *`HelpAudience`*
- override void UseHelpOption(Question q, Dictionary<string, int> answerChoices)

### *`HelpFiftyFifty`*
- override void UseHelpOption(Question q, Dictionary<string, int> answerChoices)
