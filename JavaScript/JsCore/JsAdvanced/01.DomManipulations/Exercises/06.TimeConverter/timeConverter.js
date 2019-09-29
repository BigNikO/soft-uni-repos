function attachEventsListeners() {
  function convertDays() {
    let value = +document.getElementById('days').value;
    document.getElementById('hours').value = 24 * value;
    document.getElementById('minutes').value = 24 * 60 * value;
    document.getElementById('seconds').value = 24 * 60 * 60 * value;
  }

  function convertHours() {
    let value = +document.getElementById('hours').value;
    document.getElementById('days').value = value / 24;
    document.getElementById('minutes').value = 60 * value;
    document.getElementById('seconds').value = 60 * 60 * value;
  }

  function convertMinutes() {
    let value = +document.getElementById('minutes').value;
    document.getElementById('days').value = value / (24 * 60);
    document.getElementById('hours').value = value / 60;
    document.getElementById('seconds').value = 60 * value;
  }

  function convertSeconds() {
    let value = +document.getElementById('seconds').value;
    document.getElementById('days').value = value / (24 * 60 * 60);
    document.getElementById('hours').value = value / (60 * 60);
    document.getElementById('minutes').value = value / 60;
  }

  document.getElementById('daysBtn').addEventListener('click', convertDays);
  document.getElementById('hoursBtn').addEventListener('click', convertHours);
  document
    .getElementById('minutesBtn')
    .addEventListener('click', convertMinutes);
  document
    .getElementById('secondsBtn')
    .addEventListener('click', convertSeconds);
}
