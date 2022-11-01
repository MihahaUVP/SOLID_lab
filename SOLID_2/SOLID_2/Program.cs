// See https://aka.ms/new-console-template for more information
using SOLID_2;

var simpleLayout = new SimpleLayout();
var consoleAppender = new ConsoleAppender(simpleLayout);

var file = new LogFile();
var fileAppender = new FileAppender(simpleLayout, file);

var logger = new Logger(consoleAppender, fileAppender);
logger.Error("3/26/2022 2:08:11 PM", "Error parsing JSON.");
logger.Info("3/26/2022 2:08:11 PM", "User Ivan successfully registered.");
