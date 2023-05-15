PersonModel person = new PersonModel();
person.firstName = "What's your first name: ".RequestString();
person.lastName = "What's your last name: ".RequestString();
person.Age = "How old are you: ".RequestInt(0, 120);
