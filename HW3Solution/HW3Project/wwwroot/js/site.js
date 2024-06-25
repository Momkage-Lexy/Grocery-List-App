// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

// Event handler for deleting items
document.getElementById("listForm").onsubmit = function (e) {
  // Select all checked checkboxes
  var checkboxes = document.querySelectorAll(
    'input[name="selectedItems"]:checked'
  );
  if (checkboxes.length === 0) {
    // Displays error if no boxes are checked and prevents default
    document.getElementById("deleteError").style.display = "block";
    e.preventDefault();
  } else {
    // No error message and action continues
    document.getElementById("deleteError").style.display = "none";
  }
};
