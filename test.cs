import React from 'react';
import {
    Chart as ChartJS,
    CategoryScale,
    LinearScale,
    PointElement,
    LineElement,
    Title,
    Tooltip,
    Legend,
} from 'chart.js';
import { Line } from 'react-chartjs-2';

ChartJS.register(
    CategoryScale,
    LinearScale,
    PointElement,
    LineElement,
    Title,
    Tooltip,
    Legend
);

export const options = {
    responsive: true,
    interaction: {
        mode: 'index',
        intersect: false,
    },
    stacked: false,
    plugins: {
        title: {
            display: true,
            text: 'Rate Watch Chart',
        },
    },
    scales: {
        y1: {
            type: 'linear' ,
            display: true,
            position: 'left' ,
            reverse:true
        },
    },
};

const labels = ['1300-01-01 20202', '1300-01-01 20202', '1300-01-01 20202', '1300-01-01 20202', '1300-01-01 20202', '1300-01-01 20202', '1300-01-01 20202'];

export const data = {
    labels,
    datasets: [
        {
            label: 'Rate',
            data: [100,3,2,1],
            borderColor: 'rgb(23,115,218)',
            backgroundColor: 'rgba(1,35,255,0.5)',
            yAxisID: 'y1',
        },
    ],
};

export function App() {
    return <Line options={options} data={data} />;
}


{
  "name": "login",
  "version": "0.1.0",
  "private": true,
  "dependencies": {
    "@testing-library/jest-dom": "^5.16.4",
    "@testing-library/react": "^13.2.0",
    "@testing-library/user-event": "^13.5.0",
    "axios": "^0.27.2",
    "chart.js": "^3.7.1",
    "cors": "^2.8.5",
    "cra-template-typescript": "^1.2.0",
    "faker": "^6.6.6",
    "react": "^18.1.0",
    "react-chartjs-2": "^4.1.0",
    "react-dom": "^18.1.0",
    "react-scripts": "5.0.1",
    "web-vitals": "^2.1.4"
  },
  "scripts": {
    "start": "react-scripts start",
    "build": "react-scripts build",
    "test": "react-scripts test",
    "eject": "react-scripts eject",
    "server": "node ./server/index.js"
  },
  "eslintConfig": {
    "extends": [
      "react-app",
      "react-app/jest"
    ]
  },
  "browserslist": {
    "production": [
      ">0.2%",
      "not dead",
      "not op_mini all"
    ],
    "development": [
      "last 1 chrome version",
      "last 1 firefox version",
      "last 1 safari version"
    ]
  }
}

