function addItem() {
  let inputText = document.getElementById('newItemText');
  let inputValue = document.getElementById('newItemValue');

  let option = document.createElement('option');
  option.textContent = inputText.value;
  option.value = inputValue.value;

  document.getElementById('menu').appendChild(option);

  inputText.value = '';
  inputValue.value = '';
}
