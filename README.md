# Blazor Examples

## [Counter auto-refresh example (Blazor Server)](src/BlazorAutoRefreshApp/)

Extended Counter functionality of the Blazor Server default app:

* The current counter value is stored in a singleton instance so that the current counter value is shared throughout the application.
* Added an event to notify the Counter page of any changes to the counter value.

![Demo of the BlazorAutoRefreshApp where two individual browser sessions see the same counter value](doc/BlazorAutoRefreshApp.gif)
