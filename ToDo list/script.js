//Selecting the elements from the DOM
const jokeBtn = document.getElementById('fetch-users');
const jokeText = document.getElementById('user-cards');
//Arrow function to fetch data from the API
const fetchUsers = () => 
    fetch('https://jsonplaceholder.typicode.com/users') // Fetching data from the API   
    .then(response => response.json()) // Converting the response to JSON format
    .then(users => {
        // Destructuring the user data and creating HTML cards using template literals
        const userCards = users.map(({ id, name, email, phone }) => `
            <div class="user-card">
                <h3>${name}</h3>
                <p><strong>ID:</strong> ${id}</p>
                <p><strong>Email:</strong> ${email}</p>
                <p><strong>Phone:</strong> ${phone}</p>
            </div>
        `).join('');
        // Displaying the user cards on the page
        jokeText.innerHTML = userCards;
    });

    // Adding event listener to the button to fetch users when clicked
jokeBtn.addEventListener('click', fetchUsers);