USE [QuestionApp]
GO
SET IDENTITY_INSERT [dbo].[Questions] ON 

GO
INSERT [dbo].[Questions] ([Id], [QuestionText], [Answer]) VALUES (1, N'What is your favorite programming language, and why?', N'C#.   All of the perks that visual studio provides as an IDE and it''s what I''m most familiar with!')
GO
INSERT [dbo].[Questions] ([Id], [QuestionText], [Answer]) VALUES (2, N'Tabs or spaces, and why?', N'To be honest, I''m not very opinionated on either.  Ideally developers working in the same code base should agree to one or the other obvioulsy.  If I were the one making that decision, it would be tabs because of the consistency.')
GO
INSERT [dbo].[Questions] ([Id], [QuestionText], [Answer]) VALUES (3, N'Do you have a Github account?', N' My github account - https://github.com/domviano.  Although, I have been using BitBucket lately for my personal projects. ')
GO
INSERT [dbo].[Questions] ([Id], [QuestionText], [Answer]) VALUES (4, N'What does JSON stand for?', N'Javascript Object Notation.  Example: { "Development": "IsFun" }')
GO
SET IDENTITY_INSERT [dbo].[Questions] OFF
GO
