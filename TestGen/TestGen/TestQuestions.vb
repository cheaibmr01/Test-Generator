Module TestQuestions
    Structure testQuestion
        <VBFixedString(100)> Public question As String
        <VBFixedString(30)> Public choiceA As String
        <VBFixedString(30)> Public choiceB As String
        <VBFixedString(30)> Public choiceC As String
        <VBFixedString(30)> Public choiceD As String
        <VBFixedString(1)> Public correctAnswer As String
    End Structure

    Public Const MaxNoOfQuestions = 10

    Public test(MaxNoOfQuestions - 1) As testQuestion

    Public NumOfQuest As Integer
    Public CorrectAnswer As Double
    Public WrongAnswer As Double
    Public StudentTotalScore As Double
    Public StudentChoice(MaxNoOfQuestions) As String
    Public TookTest As Boolean

End Module
