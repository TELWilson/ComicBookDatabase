// add pageTitle
 const pageTitle = 'My Shopping List'
// add groceries
const groceries = [
  {item: 'cheese'},
  {item: 'popcorn'}, 
  {item:'toilet paper'}, 
  {item: 'eggs'}, 
  {item: 'bread'}, 
  {item:'mint chip ice cream'}, 
  {item:'oreos'}, 
  {item: 'milk'}, 
  {item: 'kool-aid'}, 
  {item: 'bananas'}
]

/**
 * This function will get a reference to the title and set its text to the value
 * of the pageTitle variable that was set above.
 */
function setPageTitle() {
  const title = document.querySelector('#title');

  title.innerText = pageTitle;
}

/**
 * This function will loop over the array of groceries that was set above and add them to the DOM.
 */
function displayGroceries() {
  const groc = document.querySelector('#groceries');
//forEach over groceries
groceries.forEach(grocery =>
  {
    //Create a new li and store it in a variable named container
    let container = document.createElement('li');

    //Add the 'grocery' class to the element we just created
    container.classList.add('grocery');

    container.innerText = grocery.item;
   

    //addGrocery(container, grocery.groceries);
     

// Add the new li to the main application area
    groc.appendChild(container);
  });
}

/**
 * This function will be called when the button is clicked. You will need to get a reference
 * to every list item and add the class completed to each one
 */
function markCompleted() {
  //querySelectorAll('li')
  const comp = document.querySelectorAll('li');
  comp.forEach(li => li.classList.add('completed'));
  

  //let button = document.querySelector('.btn');

  

  

}

setPageTitle();

displayGroceries();

// Don't worry too much about what is going on here, we will cover this when we discuss events.
document.addEventListener('DOMContentLoaded', () => {
  // When the DOM Content has loaded attach a click listener to the button
  const button = document.querySelector('.btn');
  button.addEventListener('click', markCompleted);
});
