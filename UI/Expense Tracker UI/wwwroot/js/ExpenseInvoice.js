    //document.getElementById('fetchButton').addEventListener('click', function() {

        fetch(`https://localhost:7205/api/expense/GetExpense`)
            .then(response => {
                // Check if the request was successful
                if (!response.ok) {
                    throw new Error('Network response was not ok');
                }
                // Parse the JSON response
                return response.json();
            })
            .then(data => {
                // Handle the data returned from the server
                console.log('Get request response:', data);
            })
            .catch(error => {
                // Handle any errors that occurred during the fetch
                console.error('There was a problem with the fetch operation:', error);
            });

    //    alert('fetch button called');
    //    console.log('button cslled')

    //});






