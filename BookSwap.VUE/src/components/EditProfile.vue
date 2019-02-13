<!--

// Creating user with user fields

admin.auth().createUser({

  // option for setting custom uid
  // uid: "some-uid",

  email: "user@example.com",
  emailVerified: false,
  phoneNumber: "+11234567890",
  password: "secretPassword",
  displayName: "John Doe",
  photoURL: "http://www.example.com/12345678/photo.png",
  disabled: false
})
  .then(function(userRecord) {
    // See the UserRecord reference doc for the contents of userRecord.
    console.log("Successfully created new user:", userRecord.uid);
    })
  .catch(function(error) {
    console.log("Error creating new user:", error);
  });


------


Get currently signed-in user:


var user = firebase.auth().currentUser;

if (user) {
  // User is signed in.
} else {
  // No user is signed in.
}

OR

firebase.auth().onAuthStateChanged(function(user) {
  if (user) {
    // User is signed in.
  } else {
    // No user is signed in.
  }
});

------

// Get User Profile

var user = firebase.auth().currentUser;
var uid, name, email, photoUrl;

if (user != null) {
  uid = user.uid;
  name = user.displayName;
  email = user.email;
  photoUrl = user.photoURL;
}

// Set User Profile

var user = firebase.auth().currentUser;
var newName;

user.updateProfile({
  displayName: newName,
  photoURL: "https://example.com/jane-q-user/profile.jpg"
}).then(function() {
  // Update successful.
}).catch(function(error) {
  // An error happened.
});


OR

// Update a User


admin.auth().updateUser(uid, {
  email: "modifiedUser@example.com",
  phoneNumber: "+11234567890",
  emailVerified: true,
  password: "newPassword",
  displayName: "Jane Doe",
  photoURL: "http://www.example.com/12345678/photo.png",
  disabled: true
})
  .then(function(userRecord) {
    // See the UserRecord reference doc for the contents of userRecord.
    console.log("Successfully updated user", userRecord.toJSON());
  })
  .catch(function(error) {
    console.log("Error updating user:", error);
  });


// Reset User Password

var user = firebase.auth().currentUser;
var newPassword = getASecureRandomPassword();

user.updatePassword(newPassword).then(function() {
  // Update successful.
}).catch(function(error) {
  // An error happened.
});



-->
