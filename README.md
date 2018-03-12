# Final-Code-Motorsports-Encyclopedia
For TINFO 431A by Thejai Riem

Final iterations for my project include: Cleaning up extra stuff on the nav-bar, fixing the get and post on the create a "Car" page, and adding some what working restricted views.

The "Track" page has a "Create" and an "Edit" only available to the "Teacher" role. It works by restricting regular users, but I could not get it to work for the code to assign "Teacher" a role to a user to be able to create new tracks and edit them. If you want to edit or create new tracks currently you'll have to go to the "TrackController" and delete the attribute restricting a single role to create and edit.
