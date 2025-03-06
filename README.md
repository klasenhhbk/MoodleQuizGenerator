This little App should help to get more moodle quizes more fast. The main idea is to involve students to write standard quiz items that folow these rules:
1. Create a csv file
2. Use a given name standard (Praefix) folowed by your name
3. Use 12 columns:
    1. number
    2. question text
    3. answer 1 text
    4. answer 1 evaluation (letter 'r' or 'R' for right and 'f' or 'F' for false)
    5. answer 2 text
    4. answer 2 evaluation (letter 'r' or 'R' for right and 'f' or 'F' for false)
    5. answer 3 text
    4. answer 3 evaluation (letter 'r' or 'R' for right and 'f' or 'F' for false)
    5. answer 4 text
    4. answer 4 evaluation (letter 'r' or 'R' for right and 'f' or 'F' for false)
    5. answer 5 text
    4. answer 5 evaluation (letter 'r' or 'R' for right and 'f' or 'F' for false)
5. One may use a headline like No.;question;answer1;R/F;answer2;R/F;answer3;R/F;answer4;R/F;answer5;R/F but is not oliged to (We check the first cell whether or not a number or text)

This csv or a collection of as much as your like in as much and deep structure you like should be placed in the same directory as the app. All will be scanned and put together in one xml file taht meets the moodle-XML-format requirements.
Subsequently this file may be imported as such in moodle-quizes.
