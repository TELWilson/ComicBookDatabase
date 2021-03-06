let allItemsIncomplete = true;
const pageTitle = 'My Shopping List';
const groceries = [
  { id: 1, name: 'Oatmeal' },
  { id: 2, name: 'Milk' },
  { id: 3, name: 'Banana' },
  { id: 4, name: 'Strawberries' },
  { id: 5, name: 'Lunch Meat' },
  { id: 6, name: 'Bread' },
  { id: 7, name: 'Grapes' },
  { id: 8, name: 'Steak' },
  { id: 9, name: 'Salad' },
  { id: 10, name: 'Tea' }
];

/**
 * This function will get a reference to the title and set its text to the value
 * of the pageTitle variable that was set above.
 */
function setPageTitle() {
  const title = document.getElementById('title');
  title.innerText = pageTitle;
}

/**
 * This function will loop over the array of groceries that was set above and add them to the DOM.
 */
function displayGroceries() {
  const ul = document.querySelector('ul');

  groceries.forEach((item) => {
    const li = document.createElement('li');

    li.innerText = item.name;

    const checkCircle = document.createElement('i');
    checkCircle.classList.add('far', 'fa-check-circle');

    // When the list item is clicked, add the completed class to li and checkCircle
    li.addEventListener('click', e => {
      li.classList.add('completed');
    });

    checkCircle.addEventListener('click', e => {
      checkCircle.classList.add('completed');
    })

    // When the list item is double clicked, remove the completed class to li and checkCircle
    li.addEventListener('dblclick', e => {
      li.classList.remove('completed');
    });

    checkCircle.addEventListener('dblclick', e => {
      checkCircle.classList.remove('completed');
    })


    li.appendChild(checkCircle);
    ul.appendChild(li);
  });
}

// Wait for the document's content to be ready DOMContent
document.addEventListener('DOMContentLoaded', () => {
  setPageTitle();
  displayGroceries();  
  
  // TODO: Listen to the click event on the button and react appropriately (see shopping-list.md)
  const compButton = document.querySelector('.btn');
  compButton.addEventListener('click', e => {
    const comp = document.querySelectorAll('li');
    allItemsIncomplete = !allItemsIncomplete;

    if(allItemsIncomplete) {
      comp.forEach((item) => {
        item.classList.remove('completed');
        compButton.innerText = "Mark All Complete";
      } ) }
    else {   
      comp.forEach((item) => {
        item.classList.add('completed');
        compButton.innerText = 'Mark All InComplete';
      
      } )
    }
  } );
} );