/* eslint-disable no-use-before-define */
/*
 * @Author: gvillena
 * @Date: 2020-03-09 14:37:00
 * @Last Modified by: gvillena
 * @Last Modified time: 2020-03-09 14:44:48
 */

import { push } from 'connected-react-router';
import React, { useEffect, useState } from 'react';
import { useDispatch } from 'react-redux';
import { useLocation } from 'react-router-dom';

import styled from '@emotion/styled';
import { PageHeader } from '@valtx-mi2/core';
import { useIdentity } from '@valtx-mi2/identity';
import {
  Button,
  Card,
  Content,
  Icon,
  Layout,
  Modal,
  Result,
  SVGIcons,
  Spin,
  Tooltip,
} from '@valtx-mi2/ui';

import useAssetsList from '../../../core/hooks/useAssetsList';
import useStolenAlertAdd from '../../hooks/useStolenAlertAdd';
import StolenAlertStep1 from './components/stolen-alert-step1';
import StolenAlertStep2 from './components/stolen-alert-step2';
import StolenAlertStep3 from './components/stolen-alert-step3';
import StepsProgress from './components/stolen-alert-steps-progress';

const { AttentionIcon } = SVGIcons;

const steps = [
  {
    key: 1,
    title: 'Paso 1',
    description: 'Si tienes mas de un equipo seleciona el que deseas reportar.',
  },
  {
    key: 2,
    title: 'Paso 2',
    description:
      'Carga el documento de la denuncia policial y declaracion jurada.',
  },
  {
    key: 3,
    title: 'Paso 3',
    description: 'Envia tu reporte de robo.',
  },
];

const ButtonGroup = Button.Group;

const StolenAlertAddPage = () => {
  const dispatch = useDispatch();
  const identity = useIdentity();
  const location = useLocation();

  const {
    assetsList,
    assetsListFetch,
    assetsListFetchRequested,
    assetsListFetchSucceeded,
    assetsListFetchFailed,
  } = useAssetsList();

  const {
    stolenAlertAddSubmit,
    stolenAlertAddSubmitRequested,
    stolenAlertAddSubmitSucceeded,
    stolenAlertAddSubmitSucceededTicketNumber,
    stolenAlertAddSubmitFailed,
  } = useStolenAlertAdd();

  const [assetId, setAssetId] = useState(null);
  const [policeReportFile, setPoliceReportFile] = useState(null);
  const [affidavitFile, setAffidavitFile] = useState(null);
  const [currentStep, setCurrentStep] = useState(0);

  useEffect(() => {
    const { username } = identity.user;
    assetsListFetch(username);

    return function cleanup() {
      setAssetId(null);
      setPoliceReportFile(null);
      setAffidavitFile(null);
      setCurrentStep(0);
    };
  }, []);

  useEffect(() => {
    const { username } = identity.user;
    assetsListFetch(username);
    setAssetId(null);
    setPoliceReportFile(null);
    setAffidavitFile(null);
    setCurrentStep(0);
  }, [location]);

  useEffect(() => {
    if (stolenAlertAddSubmitSucceeded) {
      onStolenAlertAddSubmitSucceeded();
    }
  }, [stolenAlertAddSubmitSucceeded]);

  function onStolenAlertAddSubmitSucceeded() {
    Modal.success({
      content: (
        <Result
          status="success"
          title="Su reporte de robo sera procesado"
          subTitle={`Numero de Ticket: ${stolenAlertAddSubmitSucceededTicketNumber}`}
          icon={null}
        />
      ),
      okText: 'Aceptar',
      icon: null,
      onOk: () => dispatch(push('/home')),
      onClose: () => dispatch(push('/home')),
    });
  }

  function onNextStep() {
    setCurrentStep(currentStep + 1);
  }

  function onPrevStep() {
    setCurrentStep(currentStep - 1);
  }

  function onStolenAlertSubmit() {
    const { username: ownerId } = identity.user;
    const params = { ownerId, assetId, policeReportFile, affidavitFile };
    stolenAlertAddSubmit(params);
  }

  return (
    <Layout>
      <Spin spinning={stolenAlertAddSubmitRequested}>
        <PageHeader>
          <Icon component={AttentionIcon} style={{ 'margin-right': '3px' }} />{' '}
          Crear Alerta de Robo
        </PageHeader>

        <Content css={{ padding: '0px 20px', position: 'relative' }}>
          <Card bodyStyle={{ padding: '30px 25px' }}>
            <StepsProgress steps={steps} current={currentStep} />
            <div css={{ marginBottom: '10px' }}>
              {currentStep === 0 && (
                <StolenAlertStep1
                  loading={assetsListFetchRequested}
                  data={assetsList}
                  change={(id) => setAssetId(id)}
                  selected={assetId}
                />
              )}
              {currentStep === 1 && (
                <StolenAlertStep2
                  policeReportFile={policeReportFile}
                  affidavitFile={affidavitFile}
                  policeReportFileChange={(file) => setPoliceReportFile(file)}
                  affidavitFileChange={(file) => setAffidavitFile(file)}
                />
              )}
              {currentStep === 2 && (
                <StolenAlertStep3
                  owner={identity.user}
                  asset={assetsList.find((asset) => asset.id === assetId)}
                  policeReportFile={policeReportFile}
                  affidavitFile={affidavitFile}
                  submitStolenAlert={onStolenAlertSubmit}
                />
              )}
            </div>

            {!stolenAlertAddSubmitSucceeded && (
              <div css={{ display: 'flex', justifyContent: 'space-between' }}>
                <ButtonGroup>
                  <Button
                    disabled={currentStep === 0}
                    onClick={() => onPrevStep()}
                  >
                    <Icon type="left" /> Anterior
                  </Button>
                  <Button
                    disabled={
                      currentStep === 2 ||
                      (currentStep === 0 && assetId === null) ||
                      (currentStep === 1 &&
                        (policeReportFile === null || affidavitFile === null))
                    }
                    onClick={() => onNextStep()}
                  >
                    {' '}
                    Siguiente
                    <Icon type="right" />
                  </Button>
                </ButtonGroup>
                <div>
                  {currentStep === 2 && !stolenAlertAddSubmitSucceeded && (
                    <Button
                      css={{ width: '100px' }}
                      type="primary"
                      onClick={onStolenAlertSubmit}
                    >
                      Enviar
                    </Button>
                  )}
                </div>
              </div>
            )}
          </Card>
        </Content>
      </Spin>
    </Layout>
  );
};

export default StolenAlertAddPage;
