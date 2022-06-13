const PROXY_CONFIG = [
  {
    context: [
      "/weatherforecast",
    ],
    target: "https://localhost:5050",
    secure: false
  }
]

module.exports = PROXY_CONFIG;
