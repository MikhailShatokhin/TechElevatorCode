
// add pageTitle
const pageTitle = "My Shopping List";
// add groceries
const groceries = [{name: "Milk"}, {name: "Egg"}, {name: "Cheese"}, 
{name: "Yogurt"}, {name: "Humus"}, {name: "Tobasco"}, {name: "Crackers"},
{name: "Bread"}, {name: "Flour"}, {name: "Sugar"}];
/**
 * This function will get a reference to the title and set its text to the value
 * of the pageTitle variable that was set above.
 * @param {string} pageTitle My Shopping List
 */
function setPageTitle() {{
  const title = document.getElementById("title");
  title.innerText = pageTitle;
}}

/**
 * This function will loop over the array of groceries that was set above and add them to the DOM.
 * 
*/
function displayGroceries() {
  let list = document.querySelector("ul");

  groceries.forEach(grocery => {
    let item = document.createElement("li")
    item.innerText=grocery.name;
    let obtainedOrNot = document.createElement("a");
    obtainedOrNot.setAttribute("class","shopping-list");
    item.appendChild(obtainedOrNot);
    list.appendChild(item);
  });
}

/**
 * This function will be called when the button is clicked. You will need to get a reference
 * to every list item and add the class completed to each one
 */
function markCompleted() {
  const items = document.querySelectorAll("li");
  items.forEach((item) => {
    item.setAttribute("class", "completed");
  });
}
setPageTitle();

displayGroceries();

// Don't worry too much about what is going on here, we will cover this when we discuss events.
document.addEventListener('DOMContentLoaded', () => {
  // When the DOM Content has loaded attach a click listener to the button
  const button = document.querySelector('.btn');
  button.addEventListener('click', markCompleted);
});
